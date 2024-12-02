//API do ViaCEP
$(document).ready(function () {
    $('#CEP').on('blur', function () {
        var cep = $(this).val().replace(/\D/g, '');
        if (cep.length === 8) { 
            $.getJSON(`https://viacep.com.br/ws/${cep}/json/`, function (data) {
                if (!data.erro) {
                    $('#Bairro').val(data.bairro || '')
                    $('#Cidade').val(data.localidade || '');
                    $('#UF').val(data.uf || '');
                } else {
                    $('#Bairro').val('');
                    $('#Cidade').val('');
                    $('#UF').val('');
                    alert('CEP não encontrado.');
                }
            });
        }
    });
});
