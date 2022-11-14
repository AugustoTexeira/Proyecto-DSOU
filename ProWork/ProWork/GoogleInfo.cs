global using Google.Apis.Auth.OAuth2;
global using Google.Apis.Services;
global using Google.Apis.Drive.v3;
global using Google.Apis.Json;
global using Google.Apis.Util.Store;
global using Google.Apis.Download;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ProWork
{
    internal static class GoogleInfo
    {
        public static UserCredential credencial;
        public static string ApplicationName = "Prowork";
        public static DriveService Servicio;

        public static string[] Scopes = { DriveService.Scope.Drive, DriveService.Scope.DriveFile, DriveService.Scope.DriveAppdata };

        public static void CrearToken()
        {
            using (var stream = new FileStream("credenciales.json", FileMode.Open, FileAccess.Read))
            {
                string creadPath = "token.json";

                credencial = GoogleWebAuthorizationBroker.AuthorizeAsync(
                GoogleClientSecrets.FromStream(stream).Secrets,
                Scopes,
                "user",
                CancellationToken.None,
                new FileDataStore(creadPath, true)).Result;
            }

            Servicio = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credencial,
                ApplicationName = ApplicationName
            });
        }
    }
}
