import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
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
    PeNombres: [{value:'' , disabled:true} , [Validators.required]],
    PePrimerapellido: [{value:'' , disabled:true} , [Validators.required]],
    PeSegundoapellido: [{value:'' , disabled:true} , [Validators.required]],
    PeSexo: [{value:'' , disabled:true} , [Validators.required]],
    PeFechanacimiento: [{value:'' , disabled:true} , [Validators.required]],
    PeEntidadnacimiento: [{value:'' , disabled:true} , [Validators.required]],


    PaNombres: [{value:'' , disabled:true} , [Validators.required]],
    PaPrimerapellido: [{value:'' , disabled:true} , [Validators.required]],
    PaSegundoapellido: [{value:'' , disabled:true} , [Validators.required]],
    PaNacionalidad : [{value:'' , disabled:false} , [Validators.required]],
    PaCurp : [{value:'' , disabled:false} , [Validators.required]],


    MaNombres: [{value:'' , disabled:true} , [Validators.required]],
    MaPrimerapellido: [{value:'' , disabled:true} , [Validators.required]],
    MaSegundoapellido: [{value:'' , disabled:true} , [Validators.required]],
    MaNacionalidad : [{value:'' , disabled:false} , [Validators.required]],
    MaCurp : [{value:'' , disabled:false} , [Validators.required]],

  })
}

ngOnInit(): void {
  // if(this.datosRetornados.habilitarForm === true){
  //   this.actualizar();
    
  // }
  this.formCambioNacionalidad.get('p1_nombres')?.disable();

  this.servicioeditar.getPaisDesc('ar').subscribe(res => {
    console.log(res);
    
  });
  
}
campoNoEsValido(campo: string){
  return this.formCambioNacionalidad.controls[campo].errors &&
          this.formCambioNacionalidad.controls[campo].touched
}
actualizar(){
  this.formCambioNacionalidad.patchValue(this.datosRetornados.registro);
  
}

cancelar(){
  this.enviarRegistro.emit(null);
} 


  

}
