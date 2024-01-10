import { Component, OnInit } from '@angular/core';
import { EthService } from '../services/eth.service';

@Component({
  selector: 'lib-eth',
  template: ` <p>eth works!</p> `,
  styles: [],
})
export class EthComponent implements OnInit {
  constructor(private service: EthService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
