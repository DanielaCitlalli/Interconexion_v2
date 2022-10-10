import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Genericos } from 'src/app/models/Genericos.model';
import { Nrc_Matrimonios } from 'src/app/models/Nrc_Matrimonios';
import { TarjetaServiceService } from 'src/app/services/tarjeta-service.service';
import { Toast, ToastrService } from 'ngx-toastr';
import { ThisReceiver } from '@angular/compiler';

@Component({
  selector: 'app-segundo-formulario',
  templateUrl: './segundo-formulario.component.html',
  styleUrls: ['./segundo-formulario.component.css']
})
export class SegundoFormularioComponent implements OnInit {

  formCambioSexo: FormGroup;

  listSexo: Genericos[] = [
    { valor: 'F', nombre: 'Femenino' },
    { valor: 'M', nombre: 'Masculino'}
  ]

  // @Input()verSegundoFormulario: boolean = false;
  @Input()datosRetornados: any;
  

  constructor(private formBuilder: FormBuilder,
    private toastr: ToastrService
    , private servicioeditar: TarjetaServiceService) { 
    this.formCambioSexo = this.formBuilder.group({
      p1Nombres: ['' , [Validators.required]],
      p1Primerapellido: ['' , [Validators.required]],
      p1Segundoapellido: ['' , [Validators.required]],
      p1Sexo: ['' , [Validators.required]],
      
      p2Nombres: ['' , [Validators.required]],
      p2Primerapellido: ['' , [Validators.required]],
      p2Segundoapellido: ['' , [Validators.required]],
      p2Sexo: ['' , [Validators.required]],
     
    })
  }

  ngOnInit(): void {
    if(this.datosRetornados.habilitarForm === true){
      this.actualizar()
      console.log(this.datosRetornados.registro.cadena);
      
    }
    console.log(this.datosRetornados);
    this.formCambioSexo.get('p1_nombres')?.disable();
    
  }

  guardarCambios(){

    // const formMatrimonio: Nrc_Matrimonios = {
    //   numeroacta: this.datosRetornados.registro.numeroacta,
    //   anioregistro:this.datosRetornados.registro.anioregistro,
    //   tipodocumento:this.datosRetornados.registro.tipodocumento,
    //   entidadregistro:this.datosRetornados.registro.entidadregistro,
    //   municipioregistro:this.datosRetornados.registro.municipioregistro,
    //   oficilia:this.datosRetornados.registro.oficilia,
    //   actabis:this.datosRetornados.registro.actabis,
    //   cadena:this.datosRetornados.registro.cadena,
    //   p1sexo: this.formCambioSexo.get('p1Sexo')?.value,
    //   p2sexo: this.formCambioSexo.get('p2Sexo')?.value

    // }
    const formMatrimonio: Nrc_Matrimonios =this.datosRetornados.registro;
    formMatrimonio.p1sexo = this.formCambioSexo.get('p1Sexo')?.value;
    formMatrimonio.p2sexo = this.formCambioSexo.get('p2Sexo')?.value;

    this.servicioeditar.putNrcMatrimonios(this.datosRetornados.registro.cadena, formMatrimonio).subscribe( data=> {
    console.log(data);
  })
    this.toastr.success("Cambio de sexo actualizado")
    console.log('Guardar cambios' , this.formCambioSexo.value);
    
  }

  campoNoEsValido(campo: string){
    return this.formCambioSexo.controls[campo].errors &&
            this.formCambioSexo.controls[campo].touched
  }

  actualizar(){
    this.formCambioSexo.patchValue(this.datosRetornados.registro)
    console.log('llegue actualizar' , this.formCambioSexo.value);
    
  }

}
