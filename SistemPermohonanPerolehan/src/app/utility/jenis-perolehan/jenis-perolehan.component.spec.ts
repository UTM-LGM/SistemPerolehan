import { ComponentFixture, TestBed } from '@angular/core/testing';

import { JenisPerolehanComponent } from './jenis-perolehan.component';

describe('JenisPerolehanComponent', () => {
  let component: JenisPerolehanComponent;
  let fixture: ComponentFixture<JenisPerolehanComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [JenisPerolehanComponent]
    });
    fixture = TestBed.createComponent(JenisPerolehanComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
