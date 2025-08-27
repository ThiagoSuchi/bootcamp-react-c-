import './Profile.css'
import { Skills } from './Skills'

export function Profile() {
    return (
        <div className="profile">
            <img src="/public/imgPerfil.png" alt="Thiago Hens Suchi" width={200} />
            <h2>Thiago Hens Suchi</h2>
            <p>System Developer</p>
            <Skills />
        </div>
    )
}