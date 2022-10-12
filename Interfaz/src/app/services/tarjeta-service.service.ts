import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { TarjetaCredito } from '../models/tarjetaCredito.model';
import { CirrTa01Napeticion } from '../models/CirrTa01Napeticion.model';
import { CirrTa03Depeticion } from '../models/CirrTa03Depeticion.model';
import { CirrTa09Mapeticion } from '../models/CirrTa09Mapeticion.model';
import { environment } from 'src/environments/environment.prod';
import { Nrc_Matrimonios } from '../models/Nrc_Matrimonios';


@Injectable({
  providedIn: 'root'
})
export class TarjetaServiceService {


  rxCadena = /^[0-9]{20,20}$/;

  myAppUrl = environment.apiUrl;
  myApiUrl = 'api/Tarjeta/';
  list: TarjetaCredito[] = [];

  myAppUrl_inter = environment.apiUrl_inter;
  myApiUrl_inter = 'api/CirrTa01Napeticion/';
  myApiUrl_interF = 'api/CirrTa01Napeticion/ForzarSubirActaNacimientos';

  myAppUrl_De = environment.apiUrl_inter;
  myApiUrl_De = 'api/CirrTa03Depeticion/';
  myApiUrl_DeF = 'api/CirrTa03Depeticion/SubirActaDefunciones';

  myAppUrl_Ma = environment.apiUrl_inter;
  myApiUrl_Ma = 'api/CirrTa09Mapeticion/';
  myApiUrl_MaF = 'api/CirrTa09Mapeticion/SubirActaMatrimonio';

  myAppUrl_NRC_Matrimonios = environment.apiUrl_inter;
  myApiUrl_NRC_Matrimonios = 'api/NrcMatrimonios/';

  registroTa01: CirrTa01Napeticion[] = [];
  list01: CirrTa01Napeticion[] = [];
  list03: CirrTa03Depeticion[] = [];
  list09: CirrTa09Mapeticion[] = [];
  lista04: Nrc_Matrimonios [] = [];


  private actualizarFormulario = new BehaviorSubject<TarjetaCredito>({} as any);

  constructor(private http: HttpClient) { }

  guardarTarjeta(tarjeta: TarjetaCredito): Observable<TarjetaCredito> {
    return this.http.post<TarjetaCredito>(this.myAppUrl + this.myApiUrl, tarjeta);
  }

  obtenerTarjetas() {
    return this.http.get(this.myAppUrl + this.myApiUrl).toPromise()
      .then(data => {
        this.list = data as TarjetaCredito[];
      });
  }

  eliminarTarjeta(id: number | undefined): Observable<TarjetaCredito> {
    return this.http.delete<TarjetaCredito>(this.myAppUrl + this.myApiUrl + id);
  }

  actualizar(tarjeta: TarjetaCredito) {
    this.actualizarFormulario.next(tarjeta);
  }

  obtenerTarjetasUpdate(): Observable<TarjetaCredito> {
    return this.actualizarFormulario.asObservable();
  }

  actualizarTarjeta(id: number | undefined, tarjeta: TarjetaCredito): Observable<TarjetaCredito> {
    return this.http.put<TarjetaCredito>(this.myAppUrl + this.myApiUrl + id, tarjeta);
  }

  // Endpoint para API Interconexion 

  //CirrTa01Napeticion
  getCirrTa01Napeticion() {
    return this.http.get(this.myAppUrl_inter + this.myApiUrl_inter).toPromise()
      .then(data => {
        this.list01 = data as CirrTa01Napeticion[];
      });
  }

  getCirrTa01NapeticionId(): Observable<CirrTa01Napeticion> {
    return this.http.get<CirrTa01Napeticion>(this.myAppUrl_inter + this.myApiUrl_inter + '6040480');
  }

  postCirrTa01Napeticion(registro: CirrTa01Napeticion): Observable<any> {
    // console.log('llegue al servicio', registro);

    return this.http.post<any>(this.myAppUrl_inter + this.myApiUrl_inter, registro);
  }
  postCirrTa01Napeticion1(registro: CirrTa01Napeticion): Observable<any> {
    // console.log('llegue al servicio Forzar subir acta nacimiento ', registro);

    return this.http.post<any>(this.myAppUrl_inter + this.myApiUrl_interF, registro);
  }

  //GET CirrTa03Depeticion
  getCirrTa03Depeticion() {
    return this.http.get(this.myAppUrl_De + this.myApiUrl_De).toPromise()
      .then(data => {
        this.list03 = data as CirrTa03Depeticion[];
      });
  }

  getCirrTa03DepeticionId(): Observable<CirrTa03Depeticion> {
    return this.http.get<CirrTa03Depeticion>(this.myAppUrl_De + this.myApiUrl_De + '72163');
  }
  
  postCirrTa03Depeticion(registro: CirrTa03Depeticion): Observable<any> {
    // console.log('llegue al servicio 03', registro);

    return this.http.post<any>(this.myAppUrl_inter + this.myApiUrl_De, registro);
  }//Borrar defuncion
  
  postCirrTa03Depeticion2(registro: CirrTa03Depeticion): Observable<any> {
    // console.log('llegue al servicio 03, forzar subir actas', registro);

    return this.http.post<any>(this.myAppUrl_De + this.myApiUrl_DeF, registro);
  }//Forzar subir Acta Defunciones


  //Get CirrTa09Mapeticion
  getCirrTa09Mapeticion() {
    return this.http.get(this.myAppUrl_Ma + this.myApiUrl_Ma).toPromise()
      .then(data => {
        this.list09 = data as CirrTa09Mapeticion[];
      });
  }
  getCirrTa09MapeticionId(): Observable<CirrTa09Mapeticion> {
    return this.http.get<CirrTa09Mapeticion>(this.myAppUrl_Ma + this.myApiUrl_Ma + '1765813');
  }

  postCirrTa09Napeticion(registro: CirrTa09Mapeticion): Observable<any> {
    // console.log('llegue al servicio 09', registro);

    return this.http.post<any>(this.myAppUrl_inter + this.myApiUrl_Ma, registro);
  }

  postCirrTa09NapeticionF(registro: CirrTa09Mapeticion): Observable<any> {
    // console.log('llegue al servicio 09 forzar subir', registro);

    return this.http.post<any>(this.myAppUrl_inter + this.myApiUrl_MaF, registro);
  }

  //GET NRC_MATRIMONIOS
  getNrcmatrimoniosId(cadena: number): Observable<Nrc_Matrimonios> {
    return this.http.get<Nrc_Matrimonios>(this.myAppUrl_NRC_Matrimonios + this.myApiUrl_NRC_Matrimonios + cadena);
  }
  putNrcMatrimonios(id:string,registro:Nrc_Matrimonios):Observable<any>{
    // console.log('llegue al servicio 09 forzar subir', registro);

    return this.http.put<any>(this.myAppUrl_NRC_Matrimonios + this.myApiUrl_NRC_Matrimonios + id , registro);
   

  }
}
