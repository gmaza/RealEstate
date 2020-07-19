import styled from 'styled-components';
import { StyledButton } from '../globals';

export const FormCard = styled.div`
    width: 100%;
    background: #ffffff;
    border: 1px solid #e8e8e8;
    box-sizing: border-box;
    box-shadow: 0px 3px 11px rgba(0, 0, 0, 0.13);
    border-radius: 5px;
    padding: 25px 15px;

    @media (min-width: 960px) {
        padding: 50px 40px;
    }
`;

export const Step = styled.div`
    font-style: normal;
    font-weight: normal;
    font-size: 16px;
    line-height: 23px;

    color: #6c6b6b;

    &.active-step {
        text-decoration-style: wavy;
        color: #f68c1e;
    }

    @media (min-width: 960px) {
        font-size: 25px;
        line-height: 36px;
    }
`;

export const NavButton = styled(StyledButton)`
    background-color: ${(props) =>
        props.variant === 'next' ? '#F8655E' : '#ffffff'};
    color: ${(props) => (props.variant === 'next' ? '#ffffff' : '#F8655E')};
    border: 1px solid #f8655e;
    display: flex;
    justify-content: center;
    align-items: center;
`;
