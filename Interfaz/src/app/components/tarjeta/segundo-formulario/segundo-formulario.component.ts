import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Genericos } from 'src/app/models/Genericos.model';
import { Nrc_Matrimonios } from 'src/app/models/Nrc_Matrimonios';
import { TarjetaServiceService } from 'src/app/services/tarjeta-service.service';
import { ToastrService } from 'ngx-toastr';
import { CirrTa09Mapeticion } from 'src/app/models/CirrTa09Mapeticion.model';

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

  @Output() enviarRegistro: EventEmitter<any> = new EventEmitter();
  

  constructor(private formBuilder: FormBuilder
    , private toastr: ToastrService
    , private servicioeditar: TarjetaServiceService) { 
    this.formCambioSexo = this.formBuilder.group({
      p1Nombres: [{value:'' , disabled:true} , [Validators.required]],
      p1Primerapellido: [{value:'' , disabled:true} , [Validators.required]],
      p1Segundoapellido: [{value:'' , disabled:true} , [Validators.required]],
      p1Sexo: [{value:'' , disabled:false} , [Validators.required]],
      
      p2Nombres: [{value:'' , disabled:true} , [Validators.required]],
      p2Primerapellido: [{value:'' , disabled:true} , [Validators.required]],
      p2Segundoapellido: [{value:'' , disabled:true} , [Validators.required]],
      
      p2Sexo: [{value:'' , disabled:false} , [Validators.required]],
     
    })
  }

  ngOnInit(): void {
    if(this.datosRetornados.habilitarForm === true){
      this.actualizar()
      // console.log(this.datosRetornados.registro.cadena);
      
    }
    // console.log(this.datosRetornados);
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

    this.enviarRegistro.emit(undefined);

    const formMatrimonio: Nrc_Matrimonios =this.datosRetornados.registro;
    formMatrimonio.p1sexo = this.formCambioSexo.get('p1Sexo')?.value;
    formMatrimonio.p2sexo = this.formCambioSexo.get('p2Sexo')?.value;

    this.servicioeditar.putNrcMatrimonios(this.datosRetornados.registro.cadena, formMatrimonio).subscribe(data => {

      if(data !== null && data !== undefined){
        this.toastr.success("Cambio de sexo actualizado");
        this.enviarRegistro.emit(data);
        
        console.log(data);
        const form09f: CirrTa09Mapeticion = {
          ta09EOid: 0,
          ta09ESecuencia: null,
          ta09EPrioridad: 1,
          ta09EOperacionacto: 1,
          ta09CCadena: data.cadena ,
          ta09FEntrada: null,
          ta09EEstatus: 0,
          ta07EEstadodest: null,
          ta07EOiddestino: null,
          ta07ESolicitarimagen: null,
          ta09FAtencion: null,
          ta09ECuantos: 0
  
        }
        this.servicioeditar.postCirrTa09Mapeticion(form09f).subscribe(data=> {

            this.enviarRegistro.emit(data);
            console.log(data);
          })
        
      }
      else{
        this.toastr.error("Ocurrio un error al actualizar")
      }


  })
    
  }

  campoNoEsValido(campo: string){
    return this.formCambioSexo.controls[campo].errors &&
            this.formCambioSexo.controls[campo].touched
  }

  actualizar(){
    this.formCambioSexo.patchValue(this.datosRetornados.registro)
    // console.log('llegue actualizar' , this.formCambioSexo.value);
    
  }
  
  cancelar(){
    this.enviarRegistro.emit(null);
  }

}
