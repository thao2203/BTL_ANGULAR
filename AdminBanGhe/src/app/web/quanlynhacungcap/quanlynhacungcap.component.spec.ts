import { ComponentFixture, TestBed } from '@angular/core/testing';

import { QuanlynhacungcapComponent } from './quanlynhacungcap.component';

describe('QuanlynhacungcapComponent', () => {
  let component: QuanlynhacungcapComponent;
  let fixture: ComponentFixture<QuanlynhacungcapComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ QuanlynhacungcapComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(QuanlynhacungcapComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
