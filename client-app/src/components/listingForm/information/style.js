import styled from 'styled-components';

export const RadioButton = styled.div`
    width: 100%;
    max-height: 140px;

    input {
        position: absolute;
        opacity: 0;
        cursor: pointer;
    }

    span {
        position: absolute;
        top: 0;
        left: 0;
        width: 100%;
        background: #ffffff;
        opacity: 0.7;
        border: 1px solid #e8e8e8;
        border-radius: 5px;
    }
`;
