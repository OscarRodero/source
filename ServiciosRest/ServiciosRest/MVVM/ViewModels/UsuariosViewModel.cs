using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ServiciosRest.MVVM.ViewModels
{
    public class UsuariosViewModel
    {
        HttpClient client;
        JsonSerializerOptions _serializerOptions;
        string baseUrl = "https://65db55833ea883a152918add.mockapi.io/";
        private List<Usuario> Usuarios;

        public UsuariosViewModel()
        {
            client = new HttpClient();
            _serializerOptions = new JsonSerializerOptions
            {
                WriteIndented = true
            };
        }
        public ICommand GetAllUsersCommand =>
        new Command(async () =>
        {
            var url = $"{baseUrl}/users";
            var respuesta = await client.GetAsync(url);
            if(respuesta.IsSuccessStatusCode) 
            {
                using(var respuestaStream = await respuesta.Content.ReadAsStreamAsync()) 
                {
                    var datos = await JsonSerializer.DeserializeAsync<List<Usuario>>(respuestaStream, _serializerOptions);
                    Usuarios = datos;
                }
            }
        });

        public ICommand GetSingleUserCommand =>
        new Command(async () =>
        {
            var url = $"{baseUrl}/users/1";
            var respuesta = await client.GetAsync(url);
            if (respuesta.IsSuccessStatusCode)
            {
                using (var respuestaStream = await respuesta.Content.ReadAsStreamAsync())
                {
                    var datos = await JsonSerializer.DeserializeAsync<Usuario>(respuestaStream, _serializerOptions);
                    var usu = new Usuario();
                    usu = datos;
                }
            }
        });

        public ICommand AddUser =>
            new Command(async () =>
            {
                var url = $"{baseUrl}/users";
                var usuario = new Usuario 
                {
                    nombre = "Óscar Rodero",
                    ciudad = "Daimiel",
                    fecha_nacimiento = DateTime.Parse("28/01/1999")
                };
                string json = JsonSerializer.Serialize<Usuario>(usuario, _serializerOptions);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                var respuesta = await client.PostAsync(url, content);
            });
    }

    
}
