namespace GradeBook.Controllers {

    export class HomeController {
        public message = 'Hi people';
    }


    export class SecretController {
        public secrets;

        constructor($http: ng.IHttpService) {
            $http.get('/api/secrets').then((results) => {
                this.secrets = results.data;
            });
        }
    }


    export class AboutController {
        public message = 'Hello from the about page!';
    }


    export class ClassSelectionController {
        public message = 'Please select 4 classes you would like to attend';
        
    }

    export class UserController {
        public user;

        constructor($http: ng.IHttpService) {
            $http.get('/api/user').then((results) => {
                this.user = results.data;
            });
        }
    }


}
