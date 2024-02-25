import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AboutSabeelComponent } from './about-sabeel.component';

describe('AboutSabeelComponent', () => {
  let component: AboutSabeelComponent;
  let fixture: ComponentFixture<AboutSabeelComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AboutSabeelComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(AboutSabeelComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
