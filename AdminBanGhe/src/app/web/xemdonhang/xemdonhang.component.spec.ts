import { ComponentFixture, TestBed } from '@angular/core/testing';

import { XemdonhangComponent } from './xemdonhang.component';

describe('XemdonhangComponent', () => {
  let component: XemdonhangComponent;
  let fixture: ComponentFixture<XemdonhangComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ XemdonhangComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(XemdonhangComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
