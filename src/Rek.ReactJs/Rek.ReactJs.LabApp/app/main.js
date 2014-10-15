requirejs.config({
	baseUrl: 'scripts'
});

requirejs([
	'Rek.ReactJs.Bindings',
	'Rek.ReactJs.UI',
	'Rek.ReactJs.LabApp'
], function() {
	Rek.ReactJs.LabApp.Program.$main();
});