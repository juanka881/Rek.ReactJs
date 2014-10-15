var gulp = require('gulp');
var connect = require('gulp-connect');
var path = require('path');

var project = {};
project.getOutput = function(projectRoot, projectName) {
	return path.join(projectRoot, projectName, 'bin/Debug', projectName + ".js");
}

var config = {};
config.projectsRoot = './src/Rek.ReactJs';
config.packagesRoot = './packages/';
config.bowerRoot = './bower_components';
config.buildRoot = './build';
config.appRoot = path.join(config.projectsRoot, 'Rek.ReactJs.LabApp/app');

config.packages = [
	path.join(config.packagesRoot, 'Saltarelle.Runtime.2.6.0/mscorlib.js'),
	path.join(config.packagesRoot, 'Saltarelle.Linq.2.4.0/linq.js')
];

config.projects = [
	project.getOutput(config.projectsRoot, 'Rek.ReactJs.Bindings'),
	project.getOutput(config.projectsRoot, 'Rek.ReactJs.LabApp'),
	project.getOutput(config.projectsRoot, 'Rek.ReactJs.UI')
];

config.bower_components = [
	path.join(config.bowerRoot, 'requirejs/require.js'),
	path.join(config.bowerRoot, 'react/react-with-addons.js')
];

gulp.task('dev', function() {
	connect.server({
		root: './build'
	});
});

gulp.task('copy', function () {

	var scriptsDest = path.join(config.buildRoot, 'scripts');
	var appDest = config.buildRoot;

	gulp.src(config.packages)
		.pipe(gulp.dest(scriptsDest));

	gulp.src(config.projects)
		.pipe(gulp.dest(scriptsDest));

	gulp.src(config.bower_components)
		.pipe(gulp.dest(scriptsDest));

	gulp.src(path.join(config.appRoot, '**')).pipe(gulp.dest(appDest));
});

gulp.task('watch', function() {
	gulp.watch(config.packages, ['copy']);
	gulp.watch(config.projects, ['copy']);
});

gulp.task('default', ['copy', 'dev', 'watch']);
