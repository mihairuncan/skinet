import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { AccountingRoutingModule } from './accounting-routing.module';
import { SharedModule } from '../shared/shared.module';



@NgModule({
  declarations: [LoginComponent, RegisterComponent],
  imports: [
    CommonModule,
    AccountingRoutingModule,
    SharedModule
  ]
})
export class AccountModule { }
