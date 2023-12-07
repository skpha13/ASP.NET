import {IReview} from "./IReview";

export interface IPost {
  title: string,
  description: string,

  reviews?: IReview[]
}
