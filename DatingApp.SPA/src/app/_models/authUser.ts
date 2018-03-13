import { User } from './user';

export interface AuthUser {
    tokenString: string;
    user: User;
}
