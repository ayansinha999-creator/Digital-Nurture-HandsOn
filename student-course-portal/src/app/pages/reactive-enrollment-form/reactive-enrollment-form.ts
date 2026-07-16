import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import {
  ReactiveFormsModule,
  FormBuilder,
  FormGroup,
  Validators
} from '@angular/forms';

@Component({
  selector: 'app-reactive-enrollment-form',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule],
  templateUrl: './reactive-enrollment-form.html',
  styleUrl: './reactive-enrollment-form.css'
})
export class ReactiveEnrollmentForm {

  enrollmentForm!: FormGroup;

  constructor(private fb: FormBuilder) {

    this.enrollmentForm = this.fb.group({
      name: ['', Validators.required],
      email: ['', [Validators.required, Validators.email]],
      course: ['', Validators.required]
    });

  }

  onSubmit() {
    if (this.enrollmentForm.valid) {
      alert('Enrollment Successful!');
      console.log(this.enrollmentForm.value);
    }
  }

}