import {IReview} from "./IReview";

export interface IPost {
  Title: string,
  Description: string

  reviews?: IReview
}
