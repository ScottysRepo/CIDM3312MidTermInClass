using System.Collections.Generic;

namespace Midterm.Models {
    public static class Repository {
        private static List<LoginViewModel> newLogin = new List<LoginViewModel>();

        public static IEnumerable<LoginViewModel> NewLogin {
            get {
                return newLogin;
            }
        }

        public static void AddLogin(LoginViewModel newlogin0) {
            newLogin.Add(newlogin0);
        }
    }
}