import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ThemnhacungcapComponent } from './themnhacungcap.component';

describe('ThemnhacungcapComponent', () => {
  let component: ThemnhacungcapComponent;
  let fixture: ComponentFixture<ThemnhacungcapComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ThemnhacungcapComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ThemnhacungcapComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
