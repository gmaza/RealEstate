import styled from 'styled-components';
import { StyledButton } from '../../globals';

export const UploadButton = styled(StyledButton)`
    display: flex;
    flex-direction: row;
    align-items: center;
    justify-content: center;
    background-color: #fff4e9;
    color: #f68c1e;
    font-style: normal;
    font-weight: 500;
    font-size: 14px;
    line-height: 14px;

    > span {
        margin-left: 10px;
    }
`;

export const Thumbnail = styled.div`
    width: 100%;
    padding-bottom: 100%;
    background-position: center center;
    background-repeat: no-repeat;
    background-size: cover;
    border-radius: 5px;
`;
