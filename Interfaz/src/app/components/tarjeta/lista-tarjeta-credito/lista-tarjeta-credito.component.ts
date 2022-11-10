import { Component, OnInit, Input, OnChanges, SimpleChanges } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { TarjetaServiceService } from 'src/app/services/tarjeta-service.service';
import { CirrTa01Napeticion } from '../../../models/CirrTa01Napeticion.model';
import { CirrTa03Depeticion } from '../../../models/CirrTa03Depeticion.model';
import { CirrTa09Mapeticion } from '../../../models/CirrTa09Mapeticion.model';



@Component({
  selector: 'app-lista-tarjeta-credito',
  templateUrl: './lista-tarjeta-credito.component.html',
  styleUrls: ['./lista-tarjeta-credito.component.css'],
})
export class ListaTarjetaCreditoComponent implements OnInit, OnChanges {

  @Input() registroAgregado: any;
  @Input() registroAgregadoCambioSexo: any;
  @Input() cadenasDisponibles?: any[];

  registroTa01?: CirrTa01Napeticion;
  registroTa03?: CirrTa03Depeticion;
  registroTa09?: CirrTa09Mapeticion;

  infoCadena: any;

  constructor(
    public tarjetaService: TarjetaServiceService,
    public toast: ToastrService
  ) {}

  ngOnChanges(changes: SimpleChanges) {
    
    this.infoCadena = undefined;
  }

  ngOnInit(): void {
    // this.tarjetaService.obtenerTarjetas();
    // //this.tarjetaService.getCirrTa01Napeticion();
    // this.tarjetaService.getCirrTa01NapeticionId().subscribe((data) => {
    //   this.registroTa01 = data;
    //   // console.log(data);
    // });

    // this.tarjetaService.getCirrTa03DepeticionId().subscribe((data) => {
    //   this.registroTa03 = data;
    //   // console.log(data ,'03!!!1');
    // });

    // this.tarjetaService.getCirrTa09MapeticionId().subscribe((data) => {
    //   this.registroTa09 = data;
    //   // console.log(data ,'09!!!!');
    // });

    // // console.log(this.registroAgregado);

    // console.log(this.registroAgregado);
    
  }

 

  ocultar() {
    this.registroAgregado = null;
    this.registroAgregadoCambioSexo = null;

    console.log(this.registroAgregado, this.registroAgregadoCambioSexo);
  }

  mostrarInfoCadena(cadena: any){
    this.infoCadena = cadena;
  }
}




