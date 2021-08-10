import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { MainService } from './main.service';

@Injectable({
  providedIn: 'root'
})

export class PizaService extends MainService {
 name:'https://localhost:5001/WeatherForecast';
  constructor(http : HttpClient) {
   super('https://localhost:5001/WeatherForecast',http)
  }
}
