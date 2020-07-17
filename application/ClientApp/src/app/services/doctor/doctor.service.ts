import { Injectable, Inject } from '@angular/core';

import {IEditableViewModel} from '../interfaces'
import { HttpClient } from '@angular/common/http';

import { Observable } from 'rxjs';

export interface Doctor extends IEditableViewModel {
  name: string;
  crm: string;
  crmuf: string;
}

@Injectable({
  providedIn: 'root'
})
export class DoctorService {

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  getDoctors(): Observable<Doctor[]> {
    return this.http.get<Doctor[]>(this.baseUrl + 'Doctor')
  }
}
