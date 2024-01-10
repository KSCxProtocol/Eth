import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';
import { EthComponent } from './components/eth.component';
import { EthService } from '@kar.Web3/eth';
import { of } from 'rxjs';

describe('EthComponent', () => {
  let component: EthComponent;
  let fixture: ComponentFixture<EthComponent>;
  const mockEthService = jasmine.createSpyObj('EthService', {
    sample: of([]),
  });
  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [EthComponent],
      providers: [
        {
          provide: EthService,
          useValue: mockEthService,
        },
      ],
    }).compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EthComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
