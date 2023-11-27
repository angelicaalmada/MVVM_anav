using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;

namespace MVVM_anav.Conexion
{
    public class Cconexion
    {
        public static FirebaseClient firebase = new FirebaseClient("https://mvvmanav-default-rtdb.firebaseio.com/");
    }
}
