import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MatToolbarModule } from '@angular/material/toolbar';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { FormsModule } from '@angular/forms'; 
import { HttpClientModule } from '@angular/common/http';
import { HomeComponent } from './home/home.component';
import { AuthguardInterceptor } from './_interceptor/authguard.interceptor';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatListModule} from '@angular/material/list';
import { LoginLayoutComponent } from './_layout/login-layout/login-layout.component';
import { HomeLayoutComponent } from './_layout/home-layout/home-layout.component';
import { PermohonanPerolehanComponent } from './permohonan-perolehan/permohonan-perolehan.component';
import { DaftarPermohonanComponent } from './daftar-permohonan/daftar-permohonan.component'
import { DatePipe } from '@angular/common';
import { UtilityComponent } from './utility/utility.component';
import { JenisPerolehanComponent } from './utility/jenis-perolehan/jenis-perolehan.component';


@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    RegisterComponent,
    HomeComponent,
    LoginLayoutComponent,
    HomeLayoutComponent,
    PermohonanPerolehanComponent,
    DaftarPermohonanComponent,
    UtilityComponent,
    JenisPerolehanComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MatToolbarModule,
    FormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot(),
    MatSidenavModule,
    MatListModule
  ],
  providers: [
    AuthguardInterceptor,
    DatePipe
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
