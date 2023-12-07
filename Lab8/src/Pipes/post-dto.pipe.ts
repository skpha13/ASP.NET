import { Pipe, PipeTransform } from '@angular/core';
import {IPost} from "../Models/IPost";

@Pipe({
  name: 'postDTO',
  standalone: true
})
export class PostDTOPipe implements PipeTransform {
  transform(value: IPost, ...args: unknown[]): IPost {
    const temp: IPost = {
      title: '',
      description: ''
    };
    temp.title = value.title;
    temp.description = value.description;
    return temp;
  }

}
