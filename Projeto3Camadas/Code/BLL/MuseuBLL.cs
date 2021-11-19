using System.Data;
using Projeto3Camadas.Code.DAL;
using Projeto3Camadas.Code.DTO;


namespace Projeto3Camadas.Code.BLL
{
    class MuseuBLL
    {
        

        acessoBancoDados conexao = new acessoBancoDados();
        string tabela = "tbl_artista";


        //O método de inserir recebe os dados via DTO
        public void Inserir (MuseuDTO medDto)
        {
            string inserir = $"insert into {tabela} values (null,'{medDto.Nome}','{medDto.Email}','{medDto.Senha}')";
            conexao.ExecutarComando(inserir);
        }

        public void Editar(MuseuDTO medDto)
        {
            string editar = $"update {tabela} set NomeArtista = '{medDto.Nome}', Email = '{medDto.Email}', senha = '{medDto.Senha}' where id = '{medDto.Id}';";

            conexao.ExecutarComando(editar);
        }
        public void Excluir(MuseuDTO medDto)
        {
            string excluir = $"delete from {tabela} where id = '{medDto.Id}';";
            conexao.ExecutarComando(excluir);
        }
        
        public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecultarConsulta(sql);
        }
    }

    
}
