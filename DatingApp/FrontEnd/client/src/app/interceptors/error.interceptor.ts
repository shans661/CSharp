import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor,
  HttpClient
} from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';

@Injectable()
export class ErrorInterceptor implements HttpInterceptor {

  constructor(private toastr: ToastrService, private route: Router) { }

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
    return next.handle(request).pipe(
      catchError(error => {
        if (error) {
          switch (error.status) {
            case 400:
              if (error.error.errors) {
                const modalStateErrors = [];
                for (const key in error.error.errors) {
                  if (error.error.errors[key]) {
                    modalStateErrors.push(key);
                  }
                }
                throw modalStateErrors;
              }
              else
              {
                this.toastr.error(error.statusText, error.status);
              }
              break;
            case 401:
              this.toastr.error("Unauthorized to access the application");
              break;
            case 404:
              this.route.navigateByUrl('/not-found');
              break;
            case 500:
              this.route.navigateByUrl('/server-errror');
              break; 
            default:
              this.toastr.error("Something went wrong");
              break;
          }
        }
        return throwError(error);
      })
    );
  }
}
