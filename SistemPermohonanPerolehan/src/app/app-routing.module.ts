import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { HomeComponent } from './home/home.component';
import { AuthguardInterceptor } from './_interceptor/authguard.interceptor';
import { LoginLayoutComponent } from './_layout/login-layout/login-layout.component';
import { HomeLayoutComponent } from './_layout/home-layout/home-layout.component';
import { PermohonanPerolehanComponent } from './permohonan-perolehan/permohonan-perolehan.component';
import { DaftarPermohonanComponent } from './daftar-permohonan/daftar-permohonan.component';
import { UtilityComponent } from './utility/utility.component';
import { JenisPerolehanComponent } from './utility/jenis-perolehan/jenis-perolehan.component';

const routes: Routes = [
  { path: '', redirectTo: 'e-perolehan', pathMatch: 'full' },
  { path: 'login', component:LoginLayoutComponent,
    children:[
      { path: '', component:LoginComponent},
    ]
  },
  { path:'register', component:LoginLayoutComponent,
    children:[
      { path: '', component: RegisterComponent},
    ]
  },
  { path: 'e-perolehan', component:HomeLayoutComponent, canActivate:[AuthguardInterceptor],
    children:[
      { path: '', redirectTo: 'home', pathMatch: 'full' },
      { path: 'home', component:HomeComponent},
      { path: 'permohonan-perolehan', component:PermohonanPerolehanComponent},
      { path: 'daftar-permohonan', component:DaftarPermohonanComponent },
      {
        path: 'utilities', component:UtilityComponent, canActivate:[AuthguardInterceptor],
        children : [
          { path:'jenis-perolehan', component:JenisPerolehanComponent }
        ]
      }
    ]
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
