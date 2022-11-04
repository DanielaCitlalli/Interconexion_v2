import { Router } from "@angular/router";
import { JwtHelperService } from "@auth0/angular-jwt";
import { Component, OnInit } from "@angular/core";

@Component({
    selector:'app-home',
    template: './home.component.html',
    styleUrls: ['./home.component.css']

})

export class HomeComponent implements OnInit{
    
    constructor(private jwtHelper: JwtHelperService){ }
    ngOnInit(): void {
    }
    isUserAuthenticated(){
        const token:string = localStorage.getItem("jwt");
        if(token && !this.jwtHelper.isTokenExpired(token)){
            return true;
        }
        else{
            return false;
        }
        logOut = ()=>{
            localStorage.removeItem("jwt");
        }
    }
}