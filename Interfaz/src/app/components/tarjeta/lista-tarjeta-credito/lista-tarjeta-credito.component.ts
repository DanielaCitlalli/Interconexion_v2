import { Component, OnInit, Input, OnChanges, SimpleChanges } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { Nrc_Matrimonios } from 'src/app/models/Nrc_Matrimonios';
import { TarjetaCredito } from 'src/app/models/tarjetaCredito.model';
import { TarjetaServiceService } from 'src/app/services/tarjeta-service.service';
import { CirrTa01Napeticion } from '../../../models/CirrTa01Napeticion.model';
import { CirrTa03Depeticion } from '../../../models/CirrTa03Depeticion.model';
import { CirrTa09Mapeticion } from '../../../models/CirrTa09Mapeticion.model';

// creo que nos hablan 


@Component({
  selector: 'app-lista-tarjeta-credito',
  templateUrl: './lista-tarjeta-credito.component.html',
  styleUrls: ['./lista-tarjeta-credito.component.css']
})
export class ListaTarjetaCreditoComponent implements OnInit, OnChanges {

 @Input() registroAgregado: any;


  
    registroTa01?: CirrTa01Napeticion;
    registroTa03?: CirrTa03Depeticion; 
    registroTa09?: CirrTa09Mapeticion;
    registroTa04?: Nrc_Matrimonios;
    

  private readonly newProperty = 'id';

  constructor(public tarjetaService: TarjetaServiceService,
              public toast: ToastrService) { }

            
              
  ngOnChanges(changes: SimpleChanges) {
    console.log(changes);
    
  }

  ngOnInit(): void {
    this.tarjetaService.obtenerTarjetas()
    //this.tarjetaService.getCirrTa01Napeticion();
      this.tarjetaService.getCirrTa01NapeticionId().subscribe(data => {
          this.registroTa01 = data;
          console.log(data);
      
    });

    this.tarjetaService.getCirrTa03DepeticionId().subscribe(data => {
      this.registroTa03 = data;
      console.log(data ,'03!!!1');
      
    });

    this.tarjetaService.getCirrTa09MapeticionId().subscribe(data => {
      this.registroTa09 = data;
      console.log(data ,'09!!!!');
      

    });
   
  }
//ahora si nomas quitale los parentesis
  eliminarTarjeta(id: number | undefined){

    if(confirm('Estas seguro de eliminar esta tarjeta?')){
      this.tarjetaService.eliminarTarjeta(id).subscribe(data => {
        this.toast.warning('Registro Eliminado', 'La tarjeta fue eliminada');
        this.tarjetaService.obtenerTarjetas();
      });
    }

    
  }

  editar(tarjeta: TarjetaCredito){
    this.tarjetaService.actualizar(tarjeta);
  }

}




