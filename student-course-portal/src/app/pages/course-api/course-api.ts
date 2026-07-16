import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ApiService } from '../../services/api';

@Component({
  selector: 'app-course-api',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './course-api.html',
  styleUrl: './course-api.css'
})
export class CourseApi implements OnInit {

  users: any[] = [];

  constructor(private apiService: ApiService) {}

  ngOnInit(): void {

    this.apiService.getUsers().subscribe({
      next: (data: any) => {
        console.log('API Response:', data);
        this.users = data;
      },
      error: (err) => {
        console.error('API Error:', err);
      }
    });

  }

}