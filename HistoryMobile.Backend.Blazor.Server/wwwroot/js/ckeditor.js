window.CKEditorInterop = (() => {
    const editors = {};
    return {
        init(id, dotNetReference) {
            ClassicEditor
                .create(document.getElementById(id))
                .then(editor => {
                    editors[id] = editor;
                    editor.model.document.on('change:data', () => {
                        let data = editor.getData();
                        document.getElementById(id).innerHTML = '';
                        document.getElementById(id).value = '';
                        document.getElementById(id).innerHTML = data;
                        document.getElementById(id).value = data;
                        let e = new Event("change");
                        var element = document.getElementById(id);
                        element.dispatchEvent(e);
                        console.log('editor change');
                    });
                })
                .catch(error => console.error(error));
        },
        destroy(id) {
            editors[id].destroy()
                .then(() => delete editors[id])
                .catch(error => console.log(error));
        }
    };
})();