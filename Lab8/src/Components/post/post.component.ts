import {Component, OnInit} from '@angular/core';
import {HttpClient, HttpClientModule} from "@angular/common/http";
import {IPost} from "../../Models/IPost";
import {MatCardModule} from "@angular/material/card";
import {CommonModule} from "@angular/common";
import {PostDTOPipe} from "../../Pipes/post-dto.pipe";

@Component({
  selector: 'app-post',
  standalone: true,
  imports: [HttpClientModule, MatCardModule, CommonModule, PostDTOPipe],
  templateUrl: './post.component.html',
  styleUrl: './post.component.scss'
})
export class PostComponent implements OnInit {
  private readonly apiUrl = "http://localhost:5109/api";
  allPosts: IPost[] = [];
  postsWithReviews: IPost[] = [];
  constructor(private readonly httpclient: HttpClient) {
  }

  ngOnInit() {
    this.httpclient.get<IPost[]>(`${this.apiUrl}/Post/Posts`).subscribe(
      (data: IPost[]) => {
        this.allPosts = data.map(post => ({title: post.title, description: post.description}));
      }
    )

    this.httpclient.get<IPost[]>(`${this.apiUrl}/Post/PostsIncludeReviews`).subscribe(
      (data: IPost[])  => {
        this.postsWithReviews = data.map(post => ({
          title: post.title,
          description: post.description,
          reviews: post.reviews?.map(post => ({
            text: post.text,
            numberStars: post.numberStars
          }))
        }));
        console.log(this.postsWithReviews);
      }
    )
  }
}
