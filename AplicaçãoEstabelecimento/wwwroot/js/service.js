// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.





/*
    $.ajax({
        url: "https://localhost:4265/api/Cadastro/listagem",
        //data: { dados: estabelecimento },
        type: "get",
        dataType: "json",
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            $("#resultado").empty();
            $("#resultado").append("erro");
        },
        success: function (data, textStatus, XMLHttpRequest) {
            $("#resultado").empty();
            $(data).each(function () {
                $("table#resultado tbody").append("<tr><td>" + this.Nome + "</td><td>" + this.Sobrenome + " </td><td>" + this.Sobrenome + " </td><td>" + this.Nome + "</td><td>" + this.Sobrenome + " </td><td>" + this.Sobrenome + " </td></tr>");
            });
        }
    });*/


var URL_API = "https://localhost:44353/api/";

function listagem() {


    $.ajax({
        url: URL_API + "Estabelecimento/Listar",
        type: "get",
        dataType: "json",
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            alertify.error('Erro oa tentar retornar a listagem de Estabelecimentos!');
        },
        success: function (data, textStatus, XMLHttpRequest) {
            console.log(data);
            $(data).each(function () {
                $("#estabelecimento tbody").append(
                    `<tr>
                        <td>${this.data_Cadastro}</td>
                        <td>${this.status}</td>
                        <td>${this.razao_Social}</td>
                        <td>${this.nome_Fantasia}</td>
                        <td>${this.categoria}</td>
                        <td>${this.cnpj}</td>
                        <td>${this.cidade}</td>
                        <td>${this.uf}</td>
                        <td><a href="/Estabelecimento/Details/${this.id}"><i class='fas fa-angle-double-right text-primary'></i></a></td>
                        <td><a href="/Estabelecimento/Edit/${this.id}"><i class='fas fa-edit text-warning'></i></a></td>
                        <td><a href="#" onclick="excluir(${this.id})"><i class='fas fa-trash-alt text-danger'></i></a></td>
                    </tr>`);
            });
        }
    });

}

function retorno(id) {

    $.ajax({
        url: URL_API + "Estabelecimento/Retornar/" + id,
        type: "get",
        dataType: "json",
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            alertify.error('Erro oa tentar retornar o Estabelecimentos!');
        },
        success: function (data, textStatus, XMLHttpRequest) {
            console.log(data);

            $('[name="Status"]').val(data.id_Status);
            $('[name="Categoria"]').val(data.categoria);
            $('[name="Data_Cadastro"]').val(data.data_Cadastro);
            $('[name="Razao_Social"]').val(data.razao_Social);
            $('[name="Nome_Fantasia"]').val(data.nome_Fantasia);
            $('[name="Cnpj"]').val(data.cnpj);
            $('[name="Telefone"]').val(data.telefone);
            $('[name="Email"]').val(data.email);
            $('[name="Cep"]').val(data.cep);
            $('[name="Logradouro"]').val(data.logradouro);
            $('[name="Numero"]').val(data.numero);
            $('[name="Bairro"]').val(data.bairro);
            $('[name="Cidade"]').val(data.cidade);
            $('[name="UF"]').val(data.uf);
            $('[name="Banco"]').val(data.banco);
            $('[name="Agencia"]').val(data.agencia);
            $('[name="Conta"]').val(data.conta);

        }
    });

}

function atualizar() {
    var estabelecimento = {
        "Id": $("#Id").val(),
        "Id_Status": $("#Status").val(),
        "Status": $("#Status").val(),
        "Data_Cadastro": $("#Data_Cadastro").val(),
        "Id_Categoria": $("#Categoria").val(),
        "Categoria": $("#Categoria").val(),
        "Razao_Social": $("#Razao_Social").val(),
        "Nome_Fantasia": $("#Nome_Fantasia").val(),
        "Cnpj": $("#Cnpj").val(),
        "Telefone": $("#Telefone").val(),
        "Email": $("#Email").val(),
        "Cep": $("#Cep").val(),
        "Logradouro": $("#Logradouro").val(),
        "Numero": $("#Numero").val(),
        "Bairro": $("#Bairro").val(),
        "Cidade": $("#Cidade").val(),
        "UF": $("#UF").val(),
        "Banco": $("#Banco").val(),
        "Agencia": $("#Agencia").val(),
        "Conta": $("#Conta").val(),
    };

    console.log(estabelecimento);
    $.ajax({
        url: URL_API + "Estabelecimento/Atualizar",
        data: { dados: JSON.stringify(estabelecimento) },
        type: "put",
        dataType: 'application/json',
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            alertify.error('Erro oa tentar Atualizar o Estabelecimento!');
        },
        success: function (data, textStatus, XMLHttpRequest) {
            alertify.success('Etabelecimento atualizado com sucesso!');
            window.location.href = "Estabelecimento/Index";
        }
    });
}