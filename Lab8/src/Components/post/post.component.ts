import {Component, OnInit} from '@angular/core';
import {HttpClient, HttpClientModule} from "@angular/common/http";

@Component({
  selector: 'app-post',
  standalone: true,
  imports: [HttpClientModule],
  templateUrl: './post.component.html',
  styleUrl: './post.component.scss'
})
export class PostComponent implements OnInit {
  private readonly apiUrl = "https://localhost:/api";
  constructor(private readonly httpclient: HttpClient) {
  }

  ngOnInit() {
    this.httpclient.get<PostComponent>(`${this.apiUrl}/Post/Posts`).subscribe(
      (data: PostComponent) => {
        console.log(data);
      }
    )
  }
}
