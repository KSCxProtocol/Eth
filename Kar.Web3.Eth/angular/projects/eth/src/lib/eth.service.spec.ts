import { TestBed } from '@angular/core/testing';
import { EthService } from './services/eth.service';
import { RestService } from '@abp/ng.core';

describe('EthService', () => {
  let service: EthService;
  const mockRestService = jasmine.createSpyObj('RestService', ['request']);
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [
        {
          provide: RestService,
          useValue: mockRestService,
        },
      ],
    });
    service = TestBed.inject(EthService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
