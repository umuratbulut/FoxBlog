$("#NewComment").click(function () {
    
    var formData = $("#comment").serialize();

    $.ajax({
        url: '/Comment/Add/',
        type: 'POST',
        dataType: 'json',
        data: formData,
        success: function (data) {
            if (data === true) {
                $("#comment")[0].reset();
                Swal.fire({
                    position: 'middle',
                    icon: 'success',
                    html: '<strong>Tebrikler!</strong> Yorumunuz tarafımıza ulaştı, onay sürecinden sonra yayına alınacaktır .',
                    showCloseButton: true,
                    showConfirmButton: false,
                })
            }
            else {
                alert(data);
            }
        }
    });
});