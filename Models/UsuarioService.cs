using System.Linq;
using System.Collections.Generic;
using System;

namespace Biblioteca.Models
{
    public class UsuarioService
    {

        public Usuario Listar(int id)
        {
            using (BibliotecaContext bbc = new BibliotecaContext())
            {
                return bbc.Usuarios.Find(id);
            }
        }

        public List<Usuario> ListarTodos(){
            using (BibliotecaContext bbc = new BibliotecaContext()){
            return bbc.Usuarios.ToList();
            }
            
        }

        public void Registrar(Usuario user){
            using (BibliotecaContext bbc = new BibliotecaContext())
            {
                bbc.Usuarios.Add(user);
                bbc.SaveChanges();
            }
        }

        

        public void Editar(Usuario user){
            using (BibliotecaContext bbc = new BibliotecaContext()){
                    Usuario u = bbc.Usuarios.Find(user.Id);
                    u.Login = user.Login;
                    u.Nome = user.Nome;
                    u.Senha = user.Senha;
                    u.Tipo = user.Tipo;
                    bbc.SaveChanges();

                }
        }




        public void Excluir(int id){
            using (BibliotecaContext bbc = new BibliotecaContext()){
                    bbc.Remove(bbc.Usuarios.Find(id));
                    bbc.SaveChanges();
                }
        }

        }
    }