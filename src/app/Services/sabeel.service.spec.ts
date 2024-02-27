import { TestBed } from '@angular/core/testing';

import { SabeelService } from './sabeel.service';

describe('SabeelService', () => {
  let service: SabeelService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SabeelService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
