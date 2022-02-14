using PRSLibrary.Models;

namespace PRSTest {
    internal class UserController {
        private PrsDbContext context;

        public UserController(PrsDbContext context) {
            this.context = context;
        }
    }
}