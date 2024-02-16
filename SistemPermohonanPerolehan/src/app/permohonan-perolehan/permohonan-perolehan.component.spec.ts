import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PermohonanPerolehanComponent } from './permohonan-perolehan.component';

describe('PermohonanPerolehanComponent', () => {
  let component: PermohonanPerolehanComponent;
  let fixture: ComponentFixture<PermohonanPerolehanComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [PermohonanPerolehanComponent]
    });
    fixture = TestBed.createComponent(PermohonanPerolehanComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
