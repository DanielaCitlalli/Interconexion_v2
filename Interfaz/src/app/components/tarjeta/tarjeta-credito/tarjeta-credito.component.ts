import { Component, OnDestroy, OnInit, Output, EventEmitter } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Subscription } from 'rxjs';
import { TarjetaCredito } from 'src/app/models/tarjetaCredito.model';
import { TarjetaServiceService } from 'src/app/services/tarjeta-service.service';
import { CirrTa01Napeticion } from '../../../models/CirrTa01Napeticion.model';
import { CirrTa03Depeticion } from '../../../models/CirrTa03Depeticion.model';
import { CirrTa09Mapeticion } from '../../../models/CirrTa09Mapeticion.model';

@Component({
  selector: 'app-tarjeta-credito',
  templateUrl: './tarjeta-credito.component.html',
  styleUrls: ['./tarjeta-credito.component.css']
})
export class TarjetaCreditoComponent implements OnInit, OnDestroy {


  @Output() registroDevuelto: EventEmitter<any> = new EventEmitter();

  form: FormGroup;

  globalForm: FormGroup;

  suscription?: Subscription;

  tarjeta?: TarjetaCredito;
  idTarjeta?: number = 0;

  constructor(private formBuilder: FormBuilder,
              private tarjetaService: TarjetaServiceService,
              private toastr: ToastrService) { 
    this.form = this.formBuilder.group({
      id: 0,
      titular: ['' , [Validators.required]],
      tarjetaCredito: ['' , [Validators.required , Validators.maxLength(16) , Validators.minLength(16)]],
      fechaExperiacion: ['' , [Validators.required , Validators.maxLength(5) , Validators.minLength(5)]],
      cvv: ['' , [Validators.required , Validators.maxLength(3) , Validators.minLength(3)]]
    });

    //form  global
    this.globalForm = this.formBuilder.group({
      proceso: ['' , [Validators.required]],
      cadena: ['' , [Validators.required , Validators.maxLength(20) , Validators.minLength(20) , Validators.pattern(this.tarjetaService.rxCadena)]]
    });


  }                                                                                                                                           

  ngOnInit(): void {
    this.suscription = this.tarjetaService.obtenerTarjetasUpdate().subscribe(data => {
      console.log(data);
      this.tarjeta = data;
      this.form.patchValue({
        titular: this.tarjeta.titular,
        tarjetaCredito: this.tarjeta.numeroTarjeta,
        fechaExperiacion: this.tarjeta.fechaExpiracion,
        cvv: this.tarjeta.cvv
      });
      this.idTarjeta = this.tarjeta.id;
    });
  }

  ngOnDestroy(){
    this.suscription?.unsubscribe();   
  }

  guardar(){

    if(this.idTarjeta === 0){
      this.agregar();
    }
    else{
      this.editar();
    }
    
  }

  agregar(){
    const tarjeta: TarjetaCredito = {
      titular: this.form.get('titular')?.value,
      numeroTarjeta: this.form.get('tarjetaCredito')?.value,
      fechaExpiracion: this.form.get('fechaExperiacion')?.value,
      cvv: this.form.get('cvv')?.value
    }

    this.tarjetaService.guardarTarjeta(tarjeta).subscribe(data => {
      this.toastr.success('Registro Agregado' , 'La tarjeta fue agregada');
      this.tarjetaService.obtenerTarjetas();
      this.form.reset();
      
    });
  }

  editar(){
    const tarjeta: TarjetaCredito = {
      id: this.tarjeta?.id,
      titular: this.form.get('titular')?.value,
      numeroTarjeta: this.form.get('tarjetaCredito')?.value,
      fechaExpiracion: this.form.get('fechaExperiacion')?.value,
      cvv: this.form.get('cvv')?.value
    }

    this.tarjetaService.actualizarTarjeta(this.idTarjeta , tarjeta).subscribe(data => {
      this.toastr.info('Registro Actualizado' , 'La tarjeta fue actualizada');
      this.tarjetaService.obtenerTarjetas();
      this.form.reset();
      this.idTarjeta = 0;
    });
  }

  campoNoEsValido(campo: string){
    return this.globalForm.controls[campo].errors &&
            this.globalForm.controls[campo].touched
  }

ejecutarGlobal(){
  const procesoValue = this.globalForm.get('proceso')?.value;
  console.log(this.globalForm.get('proceso')?.value);

  switch (procesoValue) {
    case "borrarDef":
      const form03: CirrTa03Depeticion = {
        ta03EOid: 0,
        ta03EPrioridad: 1,
        ta03EOperacionacto: 2,
        ta03CCadena: this.globalForm.get('cadena')?.value,
        ta03EEstatus: 0,
        ta03FEntrada: null,
        ta07EEstadodest: null,
        ta07EOiddestino: null,
        ta07ESolicitarimagen: null,
        ta03ESecuencia: null,
        ta03FAtencion: null,
        ta03ECuantos: 0

      }

      this.tarjetaService.postCirrTa03Depeticion(form03).subscribe(data => {
        this.toastr.success('Dato ingresado con exito');
        let infoEnviada = {
          registro: data,
          habilitarForm: false
        }
        this.registroDevuelto.emit(infoEnviada);
      });

      console.log('Borrando defuncion...');

      break;
    case "borrarMat":
      const form09: CirrTa09Mapeticion = {
        ta09EOid:0,
        ta09ESecuencia:null,
        ta09EPrioridad:1,
        ta09EOperacionacto: 2,
        ta09CCadena:this.globalForm.get('cadena')?.value,
        ta09FEntrada:null,
        ta09EEstatus:0,
        ta07EEstadodest: null,
        ta07EOiddestino: null,
        ta07ESolicitarimagen: null,
        ta09FAtencion: null,
        ta09ECuantos: 0

      }

      this.tarjetaService.postCirrTa09Napeticion(form09).subscribe(data => {
        this.toastr.success('Dato ingresado con exito');
        let infoEnviada = {
          registro: data,
          habilitarForm: false
        }
        this.registroDevuelto.emit(infoEnviada);
      });

      break;
    case "borrarNac":
      const form: CirrTa01Napeticion = {
        ta01EOid: 0,
        ta01ESecuencia: null,
        ta01EPrioridad: 1,
        ta01EOperacionacto:2,
        ta01CCadena: this.globalForm.get('cadena')?.value,
        ta01FEntrada:null,
        ta01EEstatus: 0,
        ta07EEstadodest: null,
        ta07EOiddestino: null,
        ta07ESolicitarimagen: null,
        ta01FAtencion: null,
        ta01ECuantos: 0

      }

      this.tarjetaService.postCirrTa01Napeticion(form).subscribe(data => {
        this.toastr.success('Dato ingresado con exito');
        let infoEnviada = {
          registro: data,
          habilitarForm: false
        }
        this.registroDevuelto.emit(infoEnviada);
      });
      console.log('Borrando nacimiento...');

      break;
    case "forzarSubirNac":
      const form1: CirrTa01Napeticion = {
        ta01EOid: 0,
        ta01ESecuencia: null,
        ta01EPrioridad: 1,
        ta01EOperacionacto: 1,
        ta01CCadena: this.globalForm.get('cadena')?.value,
        ta01FEntrada: null,
        ta01EEstatus: 0,
        ta07EEstadodest: null,
        ta07EOiddestino: null,
        ta07ESolicitarimagen: null,
        ta01FAtencion: null,
        ta01ECuantos: 0

      }

      this.tarjetaService.postCirrTa01Napeticion1(form1).subscribe(data => {
        this.toastr.success('Dato ingresado con exito');
        let infoEnviada = {
          registro: data,
          habilitarForm: false
        }
        this.registroDevuelto.emit(infoEnviada);
      });
      console.log('Subiendo acta nacimiento (forzada)...');

      break;
    case "forzarSubirMat":
      const form09f: CirrTa09Mapeticion = {
        ta09EOid: 0,
        ta09ESecuencia: null,
        ta09EPrioridad: 1,
        ta09EOperacionacto: 1,
        ta09CCadena: this.globalForm.get('cadena')?.value,
        ta09FEntrada: null,
        ta09EEstatus: 0,
        ta07EEstadodest: null,
        ta07EOiddestino: null,
        ta07ESolicitarimagen: null,
        ta09FAtencion: null,
        ta09ECuantos: 0

      }
      this.tarjetaService.postCirrTa09NapeticionF(form09f).subscribe(data => {
        this.toastr.success('Dato ingresado con exito');
        let infoEnviada = {
          registro: data,
          habilitarForm: false
        }
        this.registroDevuelto.emit(infoEnviada);
      });
      break;
    case "forzarSubirDef":
      const form03F: CirrTa03Depeticion = {
        ta03EOid: 0,
        ta03EPrioridad: 1,
        ta03EOperacionacto: 1,
        ta03CCadena: this.globalForm.get('cadena')?.value,
        ta03EEstatus: 0,
        ta03FEntrada: null,
        ta07EEstadodest: null,
        ta07EOiddestino: null,
        ta07ESolicitarimagen: null,
        ta03ESecuencia: null,
        ta03FAtencion: null,
        ta03ECuantos: 0

      }

      this.tarjetaService.postCirrTa03Depeticion2(form03F).subscribe(data => {
        this.toastr.success('Dato ingresado con exito');
        let infoEnviada = {
          registro: data,
          habilitarForm: false
        }
        this.registroDevuelto.emit(infoEnviada);
      });

      console.log('Subiendo acta defuncion (forzada)...');

      break;

    case "cambioSexo":
      let infoEnviada = {
        registro: this.globalForm.get('cadena')?.value,
        habilitarForm: true
      }
      this.registroDevuelto.emit(infoEnviada);
      console.log('llegue cambio de sexo');
      this.tarjetaService.getNrcmatrimoniosId(this.globalForm.get('cadena')?.value).subscribe( data => {
        console.log(data,'llegue al servicio Nrcmatrimonio ');
        
      })
      
      break;

    default:
      break;
  }
  
}

}