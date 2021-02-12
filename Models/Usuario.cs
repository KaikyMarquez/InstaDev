using InstaDev.Interfaces;
{
    
}

namespace InstaDev.Models
{
    public class Usuario :  InstaDevBase , IUsuario
    {
       public int IdUsuario { get; set; }
       public string Nome { get; set; }
       public string Foto { get; set; }

       public string DataDeNascimento { get; set; }

       public string Email { get; set; }
       
       public string UserName { get; set; }
       
       public string Senha { get; set; }

        public string PrepararLinha(Usuario u) => $"{u.IdUsuario};{u.Nome};{u.Foto};{u.DataDeNascimento};{u.Email};{u.UserName};{u.Senha}";


        public void Cadastrar(Usuario user)
    {

     string[] linha = { PrepararLinha(j) };
            File.AppendAllLines(PATH, linha);

    }

       
       
        
       
       
       
       
       
       
       
       
        
    }
}