import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { map, Observable, startWith, timeout } from 'rxjs';
import { TarjetaServiceService } from 'src/app/services/tarjeta-service.service';
import { NrcPais } from 'src/app/models/NrcPais.model';
import { Nrc_Nacimientos } from 'src/app/models/NrcNacimientos';

@Component({
  selector: 'app-tercer-formulario',
  templateUrl: './tercer-formulario.component.html',
  styleUrls: ['./tercer-formulario.component.css']
})
export class TercerFormularioComponent implements OnInit {
  
  formCambioNacionalidad: FormGroup;
  
   
  



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
guardarCambios() {


  const formNacionalidad: Nrc_Nacimientos = this.datosRetornados;
  formNacionalidad.panacionalidad = this.formCambioNacionalidad.controls["paNacionalidad"].value;
  formNacionalidad.manacionalidad = this.formCambioNacionalidad.get('maNacionalidad')?.value;
  console.log(formNacionalidad);
  // this.servicioeditar.putNrcNacimiento(this.datosRetornados.cadena, formNacionalidad).subscribe(datos => {
  //   if(datos !== null && datos !== undefined){
  //     this.toastr.success("Cambio de nacionalidad exitoso", "Cambio de nacionalidad" , {
  //       closeButton: true,
  //       timeOut: 7000,
  //     });
  //     this.enviarRegistro.emit(datos);
  
   
  
  //   }
  
  //   else{
  //     this.toastr.error("Ocurrio un error al actualizar ","Error al actualizar",{
  //       timeOut: 7000,
  //       closeButton: true,
  
  //     });
  //   }
  // })
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
