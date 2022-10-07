import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Genericos } from 'src/app/models/Genericos.model';

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

  @Input()verSegundoFormulario: boolean = false;

  constructor(private formBuilder: FormBuilder) { 
    this.formCambioSexo = this.formBuilder.group({
      p1_nombres: ['' , [Validators.required]],
      p1_primerApellido: ['' , [Validators.required]],
      p1_segundoApellido: ['' , [Validators.required]],
      p1_sexo: ['' , [Validators.required]],
      p1_paisNacimiento: ['' , [Validators.required]],
      p1_nacionalidad: ['' , [Validators.required]],
      p1_edad: ['' , [Validators.required]],
      p2_nombres: ['' , [Validators.required]],
      p2_primerApellido: ['' , [Validators.required]],
      p2_segundoApellido: ['' , [Validators.required]],
      p2_sexo: ['' , [Validators.required]],
      p2_paisNacimiento: ['' , [Validators.required]],
      p2_nacionalidad: ['' , [Validators.required]],
      p2_edad: ['' , [Validators.required]]
    })
  }

  ngOnInit(): void {
    console.log(this.verSegundoFormulario);
    this.formCambioSexo.get('p1_nombres')?.disable();
    
  }

  guardarCambios(){
    console.log('Cambiando de sexo...');
    
  }

  campoNoEsValido(campo: string){
    return this.formCambioSexo.controls[campo].errors &&
            this.formCambioSexo.controls[campo].touched
  }

}
