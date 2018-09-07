<form>
        <label>CEP: <input type="text" id="campo_cep"></label>
        <br/>
        <label>Rua: <input type="text" id="campo_rua"></label>
        <br/>
        <label>Cidade: <input type="text" id="campo_cidade"></label>
        <br/>
        <button type="button">Selecionar CEP</button>
    </form>
    <script src="script/jquery-3.1.1.min.js"></script>
    <script>
        $(document).ready(function(){
            $("#campo_cep").change(function(){
                cep = $("#campo_cep").val();
                url = "https://viacep.com.br/ws/"+cep+"/json";
                $.get(url, function(data, status) {
                    $("#campo_rua").val(data.logradouro);
                    $("#campo_cidade").val(data.localidade);
                }, "json");
            });
        });
    </script>
