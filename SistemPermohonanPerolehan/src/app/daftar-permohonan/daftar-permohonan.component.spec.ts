import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DaftarPermohonanComponent } from './daftar-permohonan.component';

describe('DaftarPermohonanComponent', () => {
  let component: DaftarPermohonanComponent;
  let fixture: ComponentFixture<DaftarPermohonanComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DaftarPermohonanComponent]
    });
    fixture = TestBed.createComponent(DaftarPermohonanComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
