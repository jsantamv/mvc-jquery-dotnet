
const modalExample = document.getElementById('exampleModal');

const showImagePreview = (imageUploader, previewImage) => {

    if (imageUploader.files && imageUploader.files[0]) {
        const reader = new FileReader();

        reader.onload = (e) => {
            $(previewImage).attr('src', e.target.result);
        }
        console.log(imageUploader.files[0]);
        reader.readAsDataURL(imageUploader.files[0]);
    }
}

const jQueryAjaxPost = (form) => {

    $.validator.unobtrusive.parse(form);

    if ($(form).valid()) {
        var ajaxConfig = {
            type: 'POST',
            url: form.action,
            data: new FormData(form),
            contentType: false,
            processData: false,
            success: function (response) {
                $("#firstTab").html(response);
            }
        }
        if ($(form).attr('enctype') == "multipart/form-data") {
            ajaxConfig["contentType"] = false;
            ajaxConfig["processData"] = false;
        }
        $.ajax(ajaxConfig);
    }
}

const closeModal = (idModal) => {
    $(`#${idModal}`).modal('hide');
}

const saveData = () => {
    alert('Tomela con leche');
}