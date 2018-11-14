// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$.validator.addMethod('Nhungdoan', function (inputValue, inputElement, paraFirstName) {
    if (inputValue.indexOf(paraFirstName) >= 0) {
        return false;
    }
    return true;
});
$.validator.unobtrusive.adapters.add('Nhung', ['nhungfirstname'], function (options) {
    var paraFirstName = options.params['nhungfirstname'];
    options.rules['Nhungdoan'] = paraFirstName;
    options.messages['Nhungdoan'] = options.message;
});