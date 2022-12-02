import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { map, Observable, startWith } from 'rxjs';
import { TarjetaServiceService } from 'src/app/services/tarjeta-service.service';

@Component({
  selector: 'app-tercer-formulario',
  templateUrl: './tercer-formulario.component.html',
  styleUrls: ['./tercer-formulario.component.css']
})
export class TercerFormularioComponent implements OnInit {
  
  formCambioNacionalidad: FormGroup;
  
   
  

guardarCambios() {
throw new Error('Method not implemented.');
}

@Output() enviarRegistro: EventEmitter<any> = new EventEmitter();

@Input()datosRetornados: any;


  

constructor(private formBuilder: FormBuilder
  , private toastr: ToastrService
  , private servicioeditar: TarjetaServiceService) { 
  this.formCambioNacionalidad = this.formBuilder.group({
    peNombres: [{value:'' , disabled:true} , [Validators.required]],
    pePrimerapellido: [{value:'' , disabled:true} , [Validators.required]],
    peSegundoapellido: [{value:'' , disabled:true} , [Validators.required]],
    peSexo: [{value:'' , disabled:true} , [Validators.required]],
    peFechanacimiento: [{value:'' , disabled:true} , [Validators.required]],
    peEntidadnacimiento: [{value:'' , disabled:true} , [Validators.required]],


    paNombres: [{value:'' , disabled:true} , [Validators.required]],
    paPrimerapellido: [{value:'' , disabled:true} , [Validators.required]],
    paSegundoapellido: [{value:'' , disabled:true} , [Validators.required]],
    paNacionalidad : [{value:'' , disabled:false} , [Validators.required]],
    paCurp : [{value:'' , disabled:true} , [Validators.required]],


    maNombres: [{value:'' , disabled:true} , [Validators.required]],
    maPrimerapellido: [{value:'' , disabled:true} , [Validators.required]],
    maSegundoapellido: [{value:'' , disabled:true} , [Validators.required]],
    maNacionalidad : [{value:'' , disabled:false} , [Validators.required]],
    maCurp : [{value:'' , disabled:true} , [Validators.required]],

  })
}

ngOnInit(): void {
  // if(this.datosRetornados.habilitarForm === true){
  //   this.actualizar();
    
  // }
  this.formCambioNacionalidad.get('p1_nombres')?.disable();
  console.log(this.datosRetornados);
  this.formCambioNacionalidad.patchValue(this.datosRetornados);

}
  
campoNoEsValido(campo: string){
  return this.formCambioNacionalidad.controls[campo].errors &&
          this.formCambioNacionalidad.controls[campo].touched
}
// actualizar(){
  
  
// }

cancelar(){
  this.enviarRegistro.emit(null);
} 
  

}
