import styled from 'styled-components';
import { FlexRow } from '../../components/globals';
import { Container as CardContainer } from '../../components/listingCard/style';

export const Section = styled.div`
    margin-top: 50px;

    .swiper-container-horizontal
        > .swiper-pagination-bullets
        .swiper-pagination-bullet {
        margin: 0 10px;
    }

    .swiper-pagination-bullet {
        width: 16px;
        height: 16px;
        background: #c4c4c4;
        opacity: 1;
    }
    .swiper-pagination-bullet-active {
        background: ${(props) =>
            props.variant === 'vip' ? '#F8655E' : '#f68c1e'};
    }

    .swiper-pagination-bullet-active::before {
        content: ' ';
        border: 1px solid
            ${(props) => (props.variant === 'vip' ? '#F8655E' : '#f68c1e')};
        border-radius: 50%;
        position: absolute;
        width: 26px;
        height: 26px;
        transform: translate(-14px, -6px);
    }

    ${CardContainer} {
        margin-bottom: ${(props) => props.variant && '60px'};
    }
`;

export const SwiperContainer = styled.div`
    margin-right: -16px;

    @media (min-width: 600px) {
        margin-right: 0;
    }
`;

export const SectionHeader = styled(FlexRow)`
    justify-content: space-between;
    margin-bottom: 15px;
`;

export const Title = styled.div`
    margin-left: 10px;
    font-style: normal;
    font-weight: bold;
    font-size: 20px;
    line-height: 20px;
    color: #404040;
`;

export const NumberOfListings = styled.div`
    font-style: normal;
    font-weight: normal;
    font-size: 12px;
    line-height: 12px;
    color: #404040;
    opacity: 0.7;

    span {
        margin: 0 12px;
    }
`;

export const SeeMore = styled(FlexRow)`
    font-style: normal;
    font-weight: 600;
    font-size: 14px;
    line-height: 18px;
    color: ${(props) => (props.variant === 'vip' ? '#F8655E' : '#F68C1E')};
    span {
        margin-right: 7px;
    }
    cursor: pointer;
`;
