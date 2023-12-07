import { PostDTOPipe } from './post-dto.pipe';

describe('PostDTOPipe', () => {
  it('create an instance', () => {
    const pipe = new PostDTOPipe();
    expect(pipe).toBeTruthy();
  });
});
