

var blazorInterop = blazorInterop || {};

blazorInterop.quillFunction = function (id) {

    var toolbarOptions = [
        [{ 'font': [] }],
        [{ 'size': ['small', false, 'large', 'huge'] }],
        ['bold', 'italic', 'underline', 'strike'],
        [{ 'color': [] }, { 'background': [] }],
        [{ 'align': [] }]
        [{ 'list': 'ordered' }, { 'list': 'bullet' }],
        [{ 'indent': '-1' }, { 'indent': '+1' }],
        ['link', 'image', 'video', 'formula'],
    ];

    let quill = new Quill(`#${id}`, {
        modules: {
            toolbar: toolbarOptions
        },
        theme: 'snow',
        placeholder: 'Create Notification...',
    });
}

blazorInterop.datatableFunction = function (id) {

    $(document).ready(function () {
        $(id).DataTable();
        console.log('document ready');
    });
}


blazorInterop.getQuillContents = function () {
    var Delta = quill.getContents();
    return Delta;

}