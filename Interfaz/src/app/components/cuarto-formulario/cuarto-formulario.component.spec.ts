import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CuartoFormularioComponent } from './cuarto-formulario.component';

describe('CuartoFormularioComponent', () => {
  let component: CuartoFormularioComponent;
  let fixture: ComponentFixture<CuartoFormularioComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CuartoFormularioComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CuartoFormularioComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
